<?php

namespace App\Http\Controllers;

use App\Models\User;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use App\Models\Randevu;
use Illuminate\Support\Facades\DB;
use function Laravel\Prompts\password;

class ApiController extends Controller
{
    public function login(Request $request)
    {
        $data = $request->only('tc', 'password');
        if (Auth::attempt($data)) {
            return response()->json([
                'success' => 'Başarılı',
            ], 200);
        }
        return response()->json([
            'error' => 'Kullanıcı adı veya şifre yanlış'
        ], 401);
    }

    public function kayitFonksiyon(Request $request)
    {
        $data = $request->only('tc', 'password', 'ad', 'soyad', 'eposta', 'dogumyili', 'cinsiyet');
        $kullaniciVarMi = User::where('tc', $data['tc'])->first();
        if (!$kullaniciVarMi) {
            User::create($data);
            return response()->json(['data' => $data], 200);
        } else {
            return response()->json(['success' => 'Bu TC kimlik numarasına ait kullanıcı zaten mevcut',], 200);
        }
    }

    public function randevuFonksiyon(Request $request)
    {
        $userTC = $request->only('tc');
        $randevular = DB::table('randevular')
            ->join('doktorlar', 'randevular.doktorTC', '=', 'doktorlar.tc')
            ->where('randevular.hastaTC', $userTC)
            ->select('randevular.*', 'doktorlar.adsoyad as doktorAd')
            ->orderByRaw("STR_TO_DATE(randevular.tarih, '%e.%m.%Y') DESC")
            ->orderBy('randevular.saat')
            ->get();
        return response()->json(['data' => $randevular], 200);
    }

    public function randevuOlustur(Request $request)
    {
        $hastaTC = $request->input('tc');
        $hastane = $request->input('hastane');
        $poliklinik = $request->input('poliklinik');
        $hekimTC = $request->input('hekim');
        $randevuTarihi = $request->input('randevuTarihi');
        $randevuSaati = $request->input('saat');
        $randevu = DB::table('randevular')->where('hastaTC', $hastaTC)->where('hastaneAdi', $hastane)->where('doktorTC', $hekimTC)->where('tarih', $randevuTarihi)->where('poliklinik', $poliklinik)->first();
        if ($randevu) {
            return response()->json(['success' => 'aynı güne randevu mecut',], 200);
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
            return response()->json(['success' => 'Başarılı',], 200);
        }
    }

    public function ilCek(Request $request)
    {
        $iller = DB::table('iller')->get();
        return response()->json($iller);
    }

    public function hastaneCek(Request $request)
    {
        $il = $request->input('il');
        $hastaneler = DB::table('hastaneler')->where('il', $il)->get();
        return response()->json($hastaneler);
    }

    public function poliklinikCek(Request $request)
    {
        $hastane = $request->input('hastaneAdi');
        $poliklinikler = DB::table('poliklinikler')->where('hastaneAdi', $hastane)->get();
        return response()->json($poliklinikler);
    }

    public function hekimCek(Request $request)
    {
        $hastane = $request->input('hastaneAdi');
        $poliklinik = $request->input('poliklinikAdi');
        $doktorlar = DB::table('doktorlar')->select('tc', 'unvan', 'adsoyad')->where('hastaneAdi', $hastane)->where('birim', $poliklinik)->get();
        return response()->json($doktorlar);
    }

    public function tarihCek(Request $request)
    {
        $hastane = $request->input('hastaneAdi');
        $poliklinik = $request->input('poliklinikAdi');
        $hekimTC = $request->input('hekimTC');
        $randevuTarihi = $request->input('tarih');
        $saatler = DB::table('randevular')->select('saat')->where('hastaneAdi', $hastane)->where('poliklinik', $poliklinik)->where('doktorTC', $hekimTC)->where('tarih', $randevuTarihi)->get();
        return response()->json($saatler);
    }

}
