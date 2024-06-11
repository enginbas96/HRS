<?php

use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\AuthController;
use \App\Http\Controllers\VeriCekController;
use \App\Http\Controllers\MailController;


Route::get('/', function () {
    return view('anasayfa');
})->name('anaSayfa');


Route::get('Giris', [AuthController::class, 'girisFonksiyon'])->name('girisSayfasi');
Route::post('Giris', [AuthController::class, 'girisFonksiyon'])->name('girisSayfasi');

Route::get('Kaydol', [AuthController::class, 'kayitFonksiyon'])->name('kaydolSayfasi');
Route::post('Kaydol', [AuthController::class, 'kayitFonksiyon'])->name('kaydolSayfasi');

Route::get('Cikis', [AuthController::class, 'cikisFonksiyon'])->name('cikis');

Route::get('Randevular', [AuthController::class, 'randevuFonksiyon'])->name('randevularSayfasi');
Route::post('Randevular', [AuthController::class, 'randevuFonksiyon'])->name('randevularSayfasi');

Route::get('Randevu-Al', [AuthController::class, 'randevuOlustur'])->name('randevuOlusturSayfasi');
Route::post('Randevu-Al', [AuthController::class, 'randevuOlustur'])->name('randevuOlusturSayfasi');

Route::get('Sifremi-Unuttum', [MailController::class, 'Gonder'])->name('sifremiUnuttumSayfasi');
Route::post('Sifremi-Unuttum', [MailController::class, 'Gonder'])->name('sifremiUnuttumSayfasi');

Route::get('Profilim', [AuthController::class, 'profilAyarları'])->name('profilSayfasi');
Route::post('Profilim', [AuthController::class, 'profilAyarları'])->name('profilSayfasi');

//Sayfa Routes
Route::get('Iletisim', [AuthController::class, 'IletisimMetod'])->name('iletisimSayfasi');
Route::get('Hakkimizda', [AuthController::class, 'HakkimizdaMetod'])->name('hakkimizdaSayfasi');
Route::get('Hastanelerimiz', [AuthController::class, 'HastanelerimizMetod'])->name('hastanelerSayfasi');
Route::get('Doktorlarimiz', [AuthController::class, 'DoktorlarimizMetod'])->name('doktorlarSayfasi');

//Randevu Al Sayfası Veri Çekme
Route::get('/A', [VeriCekController::class, 'ilCek'])->name('ilCekRoute');
Route::get('/B', [VeriCekController::class, 'hastaneCek'])->name('hastaneCekRoute');
Route::get('/C', [VeriCekController::class, 'poliklinikCek'])->name('poliklinikCekRoute');
Route::get('/D', [VeriCekController::class, 'hekimCek'])->name('hekimCekRoute');
Route::get('/E', [VeriCekController::class, 'tarihCek'])->name('tarihCekRoute');



