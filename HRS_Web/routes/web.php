<?php

use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('anasayfa');
});

Route::get('/giris', function () {
    return view('giris');
});

Route::get('/kaydol', function () {
    return view('kaydol');
});

Route::get('/iletisim', function () {
    return view('iletisim');
});
