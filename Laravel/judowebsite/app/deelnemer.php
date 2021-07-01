<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class deelnemer extends Model
{
    public $timestamps = false;
    protected $fillable = [
        'naam',
        'banden_id',
        'win',
        'loss'
    ];
    public function banden()
    {
        return $this->belongsTo('App\Banden');
    }
}
