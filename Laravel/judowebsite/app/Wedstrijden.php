<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Wedstrijden extends Model
{
    protected $table = 'wedstrijden';
    public $timestamps = false;

    protected $fillable = [
        'blauwe_judoka',
        'witte_judoka',
        'winnaar'
    ];

    public function deelnemerblauw()
    {
        return $this->belongsTo('App\deelnemer', 'blauwe_judoka');
    }

    public function deelnemerwit()
    {
        return $this->belongsTo('App\deelnemer', 'witte_judoka');
    }
}
