<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateWedstrijdenTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('wedstrijden', function (Blueprint $table) {
            $table->id();
            $table->foreignId('blauwe_judoka')->references('id')->on('deelnemers');
            $table->foreignId('witte_judoka')->references('id')->on('deelnemers');
            $table->string('winnaar', 10);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('wedstrijden');
    }
}
