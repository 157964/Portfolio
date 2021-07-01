// Invite to server
// https://discord.com/api/oauth2/authorize?client_id=859392267139416075&permissions=2048&scope=bot

//packages
const discord = require('discord.js');
const express = require('express');
const app = express();
const http = require('http');
const server = http.createServer(app);
const { Server } = require("socket.io");
const io = new Server(server);
const Dm = '352908226616098822';

//setup
const {prefix, token} = require('./BotConfig.json');
const client = new discord.Client();

client.once('ready', () => {
	console.log('Ready!');
});

client.login(token);

// Begin code
app.get('/', (req, res) => {
    res.sendFile(__dirname + '/index.html');
});

io.on('connection', (socket) => {
    console.log('a user connected');
    UpdateContent();

    socket.on('messagePackage', (msg) => {
        console.log(msg + "message received");
        DiscordmessageWrite(msg);
    });

    socket.on('disconnect', () => {
        console.log('user disconnected');
    });
});

server.listen(3000,'0.0.0.0', () => {
    console.log('listening on *:3000');
});
// End code

//functions
async function UpdateContent() {
    console.log('updateContent');
    var whileLoop = true;
    while(whileLoop) {
        var input = await DiscordMessageRead();
        console.log(input);
        if(input == 'stop') {
            whileLoop = false;
        }
        else if(input != '') {
            io.emit('message', input);
        }
    }
    console.log('loop has stopped');
}

function DiscordMessageRead() {
    return new Promise(resolve => {
        client.on('message', message => {
            if (message.content.startsWith(prefix)) {
                let receivedMessage = message.content;
                receivedMessage = receivedMessage.replace(prefix + ' ', '');
                resolve(receivedMessage);
            }
        });
    });
}

function DiscordmessageWrite(input) {
    console.log('discordmessagewrite ' + input);
    client.users.fetch(Dm, false).then((user) => {
        user.send(input);
    })
}