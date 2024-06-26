<!DOCTYPE html>
<html lang="tr">
<head>
    <title>Kaydol | ABC Özel Sağlık Hizmetleri Randevu Sistemi</title>

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
                <span class="phone-icon"><i class="fa fa-phone"></i> (216)555-5-555</span>
                <span class="date-icon"><i class="fa fa-calendar-plus-o"></i> 6:00 - 22:00 (Pzrt-Cuma)</span>
                <span class="email-icon"><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abchastane.com</a></span>
            </div>
        </div>
    </div>
</header>
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
                <li class="appointment-btn"><a href="{{route('girisSayfasi')}}">Giriş Yap</a></li>
            </ul>
        </div>
    </div>
</section>
@auth()
    <script>
        window.location.href = "{{ route('anaSayfa') }}";
    </script>
@endauth
@guest()
    <!-- Kayıt Oluştur -->
    <section id="appointment" data-stellar-background-ratio="3">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6">
                    <img src="images/giris.jpg" class="img-responsive" alt="">
                </div>
                <div class="col-md-6 col-sm-6">
                    <!-- CONTACT FORM HERE -->
                    <form id="appointment-form" role="form" method="post" action="{{route('kaydolSayfasi')}}"  onsubmit="return kontrolEt();">
                        @csrf
                        <!-- SECTION TITLE -->

                        <div class="section-title wow fadeInUp" data-wow-delay="0.4s">
                            <div style="margin-top: 20px;"></div>
                            @if($errors->has('tc'))
                                <div style="color: red;" class="alert alert-danger">
                                    {{ $errors->first('tc') }}
                                </div>
                            @endif
                            <div style="margin-top: 10px;"></div>
                            <h2>Kayıt Oluştur</h2>
                        </div>
                        <div class="wow fadeInUp" data-wow-delay="0.8s">
                            <div class="col-md-6 col-sm-6">
                                <label for="tc">TC Kimlik Numaranız</label>
                                <input type="text" class="form-control" id="tc" name="tc" placeholder="TC kimlik no" onkeypress="rakamKontrol(event)" onblur="rakamKontrol(event)" maxlength="11">
                            </div>
                            <div class="col-md-6 col-sm-6">
                                <label for="password">Şifreniz</label>
                                <input type="password" class="form-control" id="password" name="password"
                                       placeholder="Şifreniz">
                            </div>
                            <div class="col-md-6 col-sm-6">
                                <label for="ad">Adınız</label>
                                <input type="text" class="form-control" id="ad" name="ad" placeholder="Adınız" onkeypress="karakterKontrol(event)" onblur="karakterKontrol(event)" maxlength="32">
                            </div>
                            <div class="col-md-6 col-sm-6">
                                <label for="soyad">Soyadınız</label>
                                <input type="text" class="form-control" id="soyad" name="soyad" placeholder="Soyadınız" onkeypress="karakterKontrol(event)" onblur="karakterKontrol(event)" maxlength="32">
                            </div>
                            <div class="col-md-6 col-sm-6">
                                <label for="email">Email</label>
                                <input type="email" class="form-control" id="eposta" name="eposta"
                                       placeholder="Mail adresiniz">
                            </div>
                            <div class="col-md-6 col-sm-6">
                                <label for="dogumyili">Doğum Yılınız</label>
                                <input type="text" class="form-control" id="dogumyili" name="dogumyili"
                                       placeholder="Doğum yılı" onkeypress="rakamKontrol(event)" onblur="rakamKontrol(event)" maxlength="4">
                            </div>
                            <div>
                                <label for="cinsiyet">Cinsiyetiniz</label>
                                <br>
                                <label class="radio-inline">
                                    <input type="radio" name="cinsiyet" value="Kadın"><br>
                                    Kadın</label>
                                <label class="radio-inline">
                                    <input type="radio" name="cinsiyet" value="Erkek"><br>
                                    Erkek</label>
                            </div>
                            <br>
                            <button type="submit" class="form-control" id="cf-submit" name="submit">Kayıt Ol</button>
                            <div class="deneme-form">
                                <a href="{{route('girisSayfasi')}}" class="forgot-password">Zaten bir hesabınız var mı?
                                    Giriş yapın.</a>
                            </div>
                        </div>
                    </form>
                </div>
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
                    <p>Sağlığınız bizim önceliğimizdir. Size en iyi sağlık hizmetini sunabilmek için her zaman
                        buradayız. Sorularınızı yanıtlamak, randevu almak ya da önerilerinizi iletmek için bizimle
                        iletişime geçebilirsiniz.</p>
                    <div class="contact-info">
                        <p><i class="fa fa-phone"></i> (216)555-5-555</p>
                        <p><i class="fa fa-envelope-o"></i> <a href="#">bilgi@abchastane.com</a></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4">
                <div class="footer-thumb">
                    <div class="opening-hours">
                        <h4 class="wow fadeInUp" data-wow-delay="0.4s">Çalışma Saatlerimiz</h4>
                        <p>Pzrt - Cuma : <span>06:00 - 22:00 </span></p>
                        <p>Cumartesi : <span>09:00 - 20:00</span></p>
                        <p>Pazar : <span>Kapalı</span></p>
                        <p>Acil servisimiz her zaman açıktır.</p>
                    </div>
                    <ul class="social-icon">
                        <li><a href="https://www.facebook.com/" class="fa fa-facebook-square" attr="facebook icon"></a>
                        </li>
                        <li><a href="https://x.com/" class="fa fa-twitter"></a></li>
                        <li><a href="https://www.instagram.com/" class="fa fa-instagram"></a></li>
                    </ul>
                </div>
            </div>
            <div class="col-md-12 col-sm-12 border-top">
                <div class="col-md-4 col-sm-6">
                    <div class="copyright-text">
                        <p>Copyright &copy; 2010 ABC Hastane

                            | Tasarım: <a href="mailto:engin.bas96@gmail.com" target="_parent">Engin BAŞ</a></p>
                    </div>
                </div>
                <div class="col-md-6 col-sm-6">
                    <div class="footer-link">
                    </div>
                </div>
                <div class="col-md-2 col-sm-2 text-align-center" style="text-align:right;">
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
<script src="js/kaydolJS.js"></script>
</body>
</html>
