<!doctype html>
<html lang="en">
<head>
    <title>İletişim | ABC Özel Sağlık Hizmetleri Randevu Sistemi</title>

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
                    <li class="appointment-profil"><a href="{{route("profilSayfasi")}}">Profil</a></li>
                    <li class="appointment-btn"><a href="{{route("randevularSayfasi")}}">Randevularım</a></li>
                    <li class="appointment-btn1"><a href="{{route('cikis')}}">Çıkış Yap</a></li>
                </ul>
            </div>
        </div>
    </section>
@endauth
@guest()
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
                    <li class="appointment-btn"><a href="{{route("kaydolSayfasi")}}">Kayıt Ol</a></li>
                    <li class="appointment-btn"><a href="{{route("girisSayfasi")}}">Giriş Yap</a></li>
                </ul>
            </div>
        </div>
    </section>
@endguest
<!-- FOOTER -->
<footer data-stellar-background-ratio="5">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <h4 class="wow fadeInUp" data-wow-delay="0.4s">İletişim Bilgileri</h4>
                    <div class="contact-info">
                        <p><i class="fa fa-phone"></i> 0-(216)-444-4-444</p>
                        <p><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abcsaglik.com</a></p>
                    </div>
                    <ul class="social-icon">
                        <li><a href="https://www.facebook.com" class="fa fa-facebook-square" attr="facebook icon"></a>
                        </li>
                        <li><a href="https://www.x.com" class="fa fa-twitter"></a></li>
                        <li><a href="https://www.instagra.com" class="fa fa-instagram"></a></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <div class="opening-hours">
                        <h4 class="wow fadeInUp" data-wow-delay="0.4s">Çalışma Saatlerimiz</h4>
                        <p>Pazartesi - Cuma <span>06:00 - 22:00</span></p>
                        <p>Cumartesi <span>09:00 - 20:00</span></p>
                        <p>Pazar <span>Kapalı</span></p>
                    </div>
                </div>
            </div>
            <div>

                <section id="google-map">
                    <iframe
                        src="https://www.google.com/maps/embed?pb=!1m17!1m12!1m3!1d1505.2061877537258!2d28.985607056023674!3d41.01623319999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m2!1m1!2zNDHCsDAwJzU4LjAiTiAyOMKwNTknMTMuNiJF!5e0!3m2!1str!2str!4v1717243220473!5m2!1str!2str"
                        width="100%" height="350" frameborder="0" style="border:0" allowfullscreen></iframe>
                </section>
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
</body>
</html>
