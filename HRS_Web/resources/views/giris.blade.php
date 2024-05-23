<!DOCTYPE>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Özel ABC Hastanesi</title>
    <link rel="stylesheet" href ="css/giris.css" type="text/css">
</head>
<body>
<div class ="ustBar">
    <div class ="logoDiv">LOGO</div>
    <div class ="sayfalarDiv">Anasayfa</div>
    <div class ="sayfalarDiv">Hastanelerimiz</div>
    <div class ="sayfalarDiv">Birimlerimiz</div>
    <div class ="sayfalarDiv ">Kadrolarımız</div>
    <div class ="sayfalarDiv">İletişim</div>
    <div class ="girisButtonDiv">Giriş Butonu</div>
    <div class ="kaydolDiv">Kayıt Ol Butonu</div>
</div>
<div class ="ortaAlan">
    <div class="girisDiv">
        <h2>Giriş Yap</h2>
        <form>
            <label for="tc">TC kimlik Numarası</label>
            <input type="text" id="tc" name="tc" required placeholder="TC kimlik numaranızı giriniz." maxlength="11" pattern="[0-9]{11}" title="Lütfen 11 haneli TC kimlik numaranızı doğru giriniz.">
            <label for="password">Şifre</label>
            <input type="password" id="password" name="password" required placeholder="Şifrenizi giriniz." maxlength="32">
            <input type="submit" value="Giriş Yap">
        </form>
    </div>
</div>



<div class ="altBar"></div>
</body>
</html>
