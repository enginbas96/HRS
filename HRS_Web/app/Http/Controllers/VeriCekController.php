<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class VeriCekController extends Controller
{
    public function ilCek(Request $request){
        $iller = DB::table('iller')->get();
        return response()->json($iller);
    }
    public function hastaneCek(Request $request){
        $il = $request->input('il');
        $hastaneler = DB::table('hastaneler')->where('il',$il)->get();
        return response()->json($hastaneler);
    }
    public function poliklinikCek(Request $request){
        $hastane = $request->input('hastaneAdi');
        $poliklinikler = DB::table('poliklinikler')->where('hastaneAdi',$hastane)->get();
        return response()->json($poliklinikler);
    }
    public function hekimCek(Request $request){
        $hastane = $request->input('hastaneAdi');
        $poliklinik = $request->input('poliklinikAdi');
        $doktorlar = DB::table('doktorlar')->select('tc','unvan','adsoyad')->where('hastaneAdi',$hastane)->where('birim',$poliklinik)->get();
        return response()->json($doktorlar);
    }
    public function tarihCek(Request $request){
        $hastane = $request->input('hastaneAdi');
        $poliklinik = $request->input('poliklinikAdi');
        $hekimTC = $request->input('hekimTC');
        $randevuTarihi = $request->input('tarih');
        $saatler = DB::table('randevular')->select('saat')->where('hastaneAdi',$hastane)->where('poliklinik',$poliklinik)->where('doktorTC',$hekimTC)->where('tarih',$randevuTarihi)->get();
        return response()->json($saatler);
    }
}
