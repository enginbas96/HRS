<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\ApiController;

Route::post('giris',[ApiController::class,'login']);

Route::post('randevuMobil', [ApiController::class, 'randevuFonksiyon']);
Route::post('randevuAlMobil', [ApiController::class, 'randevuOlustur']);


Route::get('/A', [ApiController::class, 'ilCek']);
Route::get('/B', [ApiController::class, 'hastaneCek']);
Route::get('/C', [ApiController::class, 'poliklinikCek']);
Route::get('/D', [ApiController::class, 'hekimCek']);
Route::get('/E', [ApiController::class, 'tarihCek']);
