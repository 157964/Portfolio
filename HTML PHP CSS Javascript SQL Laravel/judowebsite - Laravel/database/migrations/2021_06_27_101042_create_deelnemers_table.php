<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateDeelnemersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('deelnemers', function (Blueprint $table) {
            $table->id();
            $table->string('naam', 50);
            $table->foreignId('banden_id')->references('id')->on('banden');
            $table->integer('win');
            $table->integer('loss');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('deelnemers');
    }
}
