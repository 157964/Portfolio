<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Laravel Test</title>
        <link href="{{ asset('css/app.css') }}" rel="stylesheet" type="text/css" />
        <script defer src="{{ asset('js/app.js') }}" type="text/js"></script>
    </head>
    <body>
        <nav class="navbar navbar-expand-lg navbar-light bg-light align-top">
            <a class="navbar-brand" href="{{ url('/')}}">Home</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="{{ url('/deelnemer') }}">Deelnemers</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="{{ url('/wedstrijden') }}">Wedstrijden</a>
                    </li>
                </ul>
            </div>
        </nav>

        <div class="container">
            @yield('content')
        </div>
        <div class="text-center p-4 card-footer fixed-bottom" style="background-color: rgba(0, 0, 0, 0.05);">
            © 2021 Copyright: Joeri Smit
        </div>
    </body>
</html>
