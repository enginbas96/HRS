<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Mail;
use Illuminate\Support\Facades\DB;

class MailController extends Controller
{
    public function Gonder(Request $request)
    {

        if ($request->method() == 'GET') {
            return view('sifremiunuttum');
        } else {
            $email = $request->input('email');
            $tc = $request->input('tc');
            $sifre = DB::table('hasta')->select('password')->where('eposta', $email)->where('tc', $tc)->get()->first();
            if ($sifre) {
                $sifre = $sifre->password;
                Mail::raw("Şifreniz: $sifre\nLütfen büyük bir titizlikle saklayınız.", function ($message) use ($email) {
                    $message->to($email)
                        ->subject('Şifremi Unuttum!');
                });
                return redirect()->back()->withErrors(['basarili' => 'Girilen TC numarasına ait şifre mail adresinize gönderilmiştir.']);

            } else {
                return redirect()->back()->withErrors(['hata' => 'Girilen TC numarası ve email adresiyle eşleşen bir kullanıcı bulunamadı. Lütfen bilgilerinizi kontrol edin.']);

            }
        }
    }
}
