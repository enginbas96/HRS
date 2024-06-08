<!doctype html>
<html lang="en">
<head>
    <title>Randevu Al | ABC Özel Sağlık Hizmetleri Randevu Sistemi</title>

    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta name="description" content="">
    <meta name="keywords" content="">
    <meta name="author" content="Tooplate">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/owl.carousel.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/tooplate-style.css">
    <link rel="stylesheet" href="css/randevuAl.css">

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body id="top" data-spy="scroll" data-target=".navbar-collapse" data-offset="50">
<!-- PRE LOADER -->
<section class="preloader">
    <div class="spinner">
        <span class="spinner-rotate"></span>
    </div>
</section>
<!-- HEADER -->
<header>
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-5">
                <p>ABC Özel Sağlık Hizmetleri</p>
            </div>
            <div class="col-md-8 col-sm-7 text-align-right">
                <span class="phone-icon"><i class="fa fa-phone"></i> 0-(216)-444-4-444</span>
                <span class="date-icon"><i class="fa fa-calendar-plus-o"></i> 6:00 - 22:00 (Pazartesi-Cuma)</span>
                <span class="email-icon"><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abcsaglik.com</a></span>
            </div>
        </div>
    </div>
</header>
@guest()
    <script>
        window.location.href = "{{ route('girisSayfasi') }}";
    </script>
@endguest
@auth()
    <!-- MENU -->
    <section class="navbar navbar-default navbar-static-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                    <span class="icon icon-bar"></span>
                </button>
                <!-- lOGO TEXT HERE -->
                <a href="{{route("anaSayfa")}}" class="navbar-brand"><i class="fa fa-h-square"></i>er şeyden önce sağlık</a>
            </div>
            <!-- MENU LINKS -->
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="{{route("anaSayfa")}}" class="smoothScroll">Anasayfa</a></li>
                    <li><a href="{{route("hakkimizdaSayfasi")}}" class="smoothScroll">Hakkımızda</a></li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Bize Dair <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="{{route("hastanelerSayfasi")}}" class="smoothScroll">Hastanelerimiz</a></li>
                            <li><a href="{{route("doktorlarSayfasi")}}" class="smoothScroll">Uzman Kadromuz</a></li>
                        </ul>
                    </li>
                    <li><a href="{{route("iletisimSayfasi")}}" class="smoothScroll">İletişim</a></li>
                    <li class="appointment-btn"><a href="{{route("randevularSayfasi")}}">Randevularım</a></li>
                    <li class="appointment-btn1"><a href="{{route('cikis')}}">Çıkış Yap</a></li>
                </ul>
            </div>
        </div>
    </section>
    <section id="appointment" data-stellar-background-ratio="3">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2>Randevu Al</h2>
                    <form action="{{ route('randevuOlusturSayfasi') }}" method="POST">
                        @csrf
                        <div class="randevuAlForm">
                            <label for="ilLabel">İl Seçiniz : </label>
                            <select id="iller" name="il" class="form-control" readonly></select>
                            <label for="hastaneLabel">Hastane Seçiniz : </label>
                            <select id="hastaneler" name="hastane" class="form-control" readonly></select>
                            <label for="polikliniklerLabel">Poliklinik Seçiniz : </label>
                            <select id="poliklinikler" name="poliklinik" class="form-control" readonly></select>
                            <label for="hekimLabel">Doktor Seçiniz : </label>
                            <select id="hekimler" name="hekim" class="form-control" readonly></select>
                            <label for="tarih" style="white-space: pre">Randevu Tarihi  :  </label>
                            <input type="date" id="randevuTarihi" name="randevuTarihi" style="width: 150px; text-align: center">
                            <div id="uyariMesaj"
                                 style="color: red; font-size: 12px; margin-top: 5px; margin-bottom: 5px;"></div>
                            <br>
                            <label id="randevuSaatiLabel" for="randevuSaati">Randevu Saatleri </label>
                            <div id="saatButonlari">
                                <button type="button" class="saatButon" value="8" onclick="saatAl(this)">08:00</button>
                                <button type="button" class="saatButon" value="9" onclick="saatAl(this)">09:00</button>
                                <button type="button" class="saatButon" value="10" onclick="saatAl(this)">10:00</button>
                                <button type="button" class="saatButon" value="11" onclick="saatAl(this)">11:00</button>
                                <button type="button" class="saatButon" value="13" onclick="saatAl(this)">13:00</button>
                                <button type="button" class="saatButon" value="14" onclick="saatAl(this)">14:00</button>
                                <button type="button" class="saatButon" value="15" onclick="saatAl(this)">15:00</button>
                                <button type="button" class="saatButon" value="16" onclick="saatAl(this)">16:00</button>
                            </div>
                            <br>
                            <input type="hidden" name ="saat" id ="saat" value="">
                            <button type="submit" class="form-control" id="cf-submit" name="submit">Randevu Al</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
@endauth
<!-- FOOTER -->
<footer data-stellar-background-ratio="5">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <h4 class="wow fadeInUp" data-wow-delay="0.4s">İletişim Bilgileri</h4>
                    <p>Hızlı ve etkili iletişim için bize ulaşın. Sağlığınızla ilgili herhangi bir sorunuz, öneriniz
                        veya isteğiniz mi var? Size yardımcı olmaktan mutluluk duyarız.</p>

                    <div class="contact-info">
                        <p><i class="fa fa-phone"></i> 0-(216)-444-4-444</p>
                        <p><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abcsaglik.com</a></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <div class="opening-hours">
                        <h4 class="wow fadeInUp" data-wow-delay="0.4s">Çalışma Saatlerimiz</h4>
                        <p>Pazartesi - Cuma <span>06:00 - 22:00</span></p>
                        <p>Cumartesi <span>09:00 - 20:00</span></p>
                        <p>Pazar <span>Kapalı</span></p>
                        <p>Acil Servisimiz 7/24 Hizmetinizdedir</p>
                    </div>
                    <ul class="social-icon">
                        <li><a href="https://www.facebook.com" class="fa fa-facebook-square" attr="facebook icon"></a>
                        </li>
                        <li><a href="https://www.x.com" class="fa fa-twitter"></a></li>
                        <li><a href="https://www.instagra.com" class="fa fa-instagram"></a></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-12 col-sm-12 border-top">
                <div class="col-md-4 col-sm-6">
                    <div class="copyright-text">
                        <p>Copyright &copy; 2009 ABC Sağlık

                            | Tasarım: <a href="mailto:engin.bas96@gmail.com" target="_parent">ENGBA</a></p>
                    </div>
                </div>
                <div class="col-md-6 col-sm-6">
                </div>
                <div class="col-md-2 col-sm-2 text-align-center">
                    <div class="angle-up-btn">
                        <a href="#top" class="smoothScroll wow fadeInUp" data-wow-delay="1.2s"><i
                                class="fa fa-angle-up"></i></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</footer>
<!-- SCRIPTS -->
<script src="js/jquery.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/jquery.sticky.js"></script>
<script src="js/jquery.stellar.min.js"></script>
<script src="js/wow.min.js"></script>
<script src="js/smoothscroll.js"></script>
<script src="js/owl.carousel.min.js"></script>
<script src="js/custom.js"></script>
<script src="js/randevuAlSayfasi.js" defer></script>
</body>
</html>



