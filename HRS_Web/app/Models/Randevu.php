<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Randevu extends Model
{
    use HasFactory;
    protected $table = 'randevular';
    public $timestamps = false;
    /**
     * The attributes that are mass assignable.
     *
     * @var array<int, string>
     */
    protected $fillable = [
        'hastaTC',
        'doktorTC',
        'hastaneAdi',
        'tarih',
        'saat',
        'poliklinik',
    ];


}

