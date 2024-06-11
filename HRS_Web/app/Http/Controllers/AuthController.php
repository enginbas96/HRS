<?php

namespace App\Http\Controllers;

use App\Models\Randevu;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Auth;
use App\Models\User;
use function Laravel\Prompts\password;

class AuthController extends Controller
{
    public function girisFonksiyon(Request $request){
        if($request ->method() == 'GET'){
            return view('girisyap');
        }
        else if($request ->method() == 'POST'){
            $data = $request ->only('tc','password');
            if(Auth::attempt($data)){
                return redirect(route('anaSayfa'));
            }
            else{
                return back()->withErrors(['kullanici' => 'Bu bilgiler ile eşleşen bir kullanıcı bulunamadı.']);
            }
        }
    }
    public function cikisFonksiyon(){
        auth()->logout();
        return redirect(route('anaSayfa'));
    }
    public function kayitFonksiyon(Request $request){
        if($request ->method() == 'GET'){
            return view('kaydol');
        }
        else if($request ->method() == 'POST'){
            $data = $request->only('tc','password','ad','soyad','eposta','dogumyili','cinsiyet');
            $kullaniciVarMi = User::where('tc', $data['tc'])->first();
            if (!$kullaniciVarMi) {
                User::create($data);
                return redirect(route('girisSayfasi'));
            } else {
                return back()->withErrors(['tc' => 'Bu TC numarasıyla zaten kayıtlı bir kullanıcı bulunmaktadır.']);
            }
        }
    }
    public function profilAyarları(Request $request){
        if($request ->method() == 'GET'){
            $userTC = auth()->user()->tc;
            $kullanici = DB::table('hasta')
                ->where('tc', $userTC)
                ->get();
            return view('profil', ['kullanici' => $kullanici]);
        }
        else if($request ->method() == 'POST'){
            $userTC = auth()->user()->tc;
            $data = $request->only('passwordO','password','passwordR');
            $kullanici = DB::table('hasta')->where('tc', $userTC)->where('password', $data['passwordO'])->first();
            if ($kullanici) {
                DB::table('hasta')->where('tc', $userTC)->update(['password' => $data['password']]);
                return back()->withErrors(['basarili' => 'Şifreniz başarıyla değiştirilmiştir.']);
            } else {
                return back()->withErrors(['basarisiz' => 'Eski şifreniz yanlış gibi görünüyor, kontrol edip tekrar deneyiniz.']);
            }
        }
    }
    public function randevuFonksiyon(Request $request){
        if ($request->method() == 'GET') {
            $userTC = auth()->user()->tc;
            $randevular = DB::table('randevular')
                ->join('doktorlar', 'randevular.doktorTC', '=', 'doktorlar.tc')
                ->where('randevular.hastaTC', $userTC)
                ->select('randevular.*', 'doktorlar.adsoyad as doktorAd')
                ->orderByRaw("STR_TO_DATE(randevular.tarih, '%e.%m.%Y') DESC")
                ->orderBy('randevular.saat')
                ->get();
            return view('randevular', ['randevular' => $randevular]);
        } elseif($request->method() == 'POST') {
        }
    }

    public function randevuOlustur(Request $request){
        if ($request->method() == 'GET') {
            return view('randevual');
        }
        elseif($request->method() == 'POST') {
            $hastaTC = auth()->user()->tc;
            $hastane = $request->input('hastane');
            $poliklinik = $request->input('poliklinik');
            $hekimTC = $request->input('hekim');
            $randevuTarihi = $request->input('randevuTarihi');
            $randevuSaati = $request->input('saat');
            $randevuTarihiPart = explode('-', $randevuTarihi );
            $randevuTarihiPart[2] = ltrim($randevuTarihiPart[2], '0');
            $randevuTarihi = $randevuTarihiPart[2] . '.' . $randevuTarihiPart[1] . '.' . $randevuTarihiPart[0];
            $randevu = DB::table('randevular')->where('hastaTC', $hastaTC)->where('hastaneAdi', $hastane)->where('doktorTC', $hekimTC)->where('tarih', $randevuTarihi)->where('poliklinik', $poliklinik)->first();
            if ($randevu) {
                return back()->withErrors(['randevuMevcut' => 'Sizin zaten aynı gün randevunuz bulunmaktadır.']);

            } else {
                $data = [
                    'hastaTC' => $hastaTC,
                    'doktorTC' => $hekimTC,
                    'hastaneAdi' => $hastane,
                    'tarih' => $randevuTarihi,
                    'saat' => $randevuSaati,
                    'poliklinik' => $poliklinik,
                ];
                Randevu::create($data);
                return redirect(route('randevularSayfasi'));
            }
        }
    }

    //Sayfa Yönlendirme

    public function iletisimMetod(Request $request){
        if ($request->method() == 'GET') {
            return view('Iletisim');

        }
    }
    public function HakkimizdaMetod(Request $request){
        if ($request->method() == 'GET') {
            return view('hakkimizda');

        }
    }
    public function HastanelerimizMetod(Request $request){
        if ($request->method() == 'GET') {
            $hastaneler = DB::table('hastaneler')->get();
            return view('hastanelerimiz', ['hastane' => $hastaneler]);
        }
    }
    public function DoktorlarimizMetod(Request $request){
        if ($request->method() == 'GET') {
            $doktorlar = DB::table('doktorlar')->select('adsoyad', 'eposta' , 'birim' , 'hastaneAdi','unvan')
                ->get();
            return view('doktorlar', ['doktor' => $doktorlar]);
        }
    }


}
