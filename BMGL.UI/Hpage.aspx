<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hpage.aspx.cs" Inherits="BMGL.UI.Hpage123" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

        <!-- Bootstrap -->
    <link href="common/css/nav.css" rel="stylesheet" />
    <link href="common/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="common/lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="common/css/Visitor.css" rel="stylesheet" />



    <script src="common/lib/html5shiv/html5shiv.min.js"></script>
    <script src="common/lib/respond/respond.min.js"></script>


</head>
<body>
    <form id="form1" runat="server">
        <!--页头-->
        <header class="HP_header hidden-sm hidden-xs">
            <div class="container">
                <div class="row">
                    <div class="col-md-5 kefu">
                        <span class="fa m-r10"><img src="common/images/GDCP-logo.png" />广东交通职业技术学院——大院社团部</span>
                    </div>
                    <div class="col-md-3">
                        <asp:Button class="btn register" ID="btnregister" runat="server" Text="管理员入口" OnClick="btnregister_Click1" />
                    </div>
                </div>
            </div>
        </header>
        <!--导航栏-->
        <nav class="HP_nav navbar navbar-default daohang">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Brand</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="Hpage.aspx">首页 <span class="sr-only">(current)</span></a></li>
                        <li><a href="common/son/shetuanfengcai.html">社团风采</a></li>
                        <li><a href="common/son/chengyuanjingying.html">成员精英</a></li>
                        <li><a href="common/son/jingcaihuodong.html">精彩活动</a></li>
                        <li><a href="common/son/guanyuwomen.html">联系我们</a></li>
                    </ul>

                </div>
            </div>
        </nav>
        <!--轮播图-->
        <div class="HP_banner">
            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <a href="#" class="img_pc img1"></a>
                        <img src="common/images/banner.jpg" alt="" />
                        <div class="carousel-caption">

                        </div>
                    </div>
                    <div class="item">
                        <a href="#" class="img_pc img2"></a>
                        <img src="common/images/banner1.jpg" alt="" />
                        <div class="carousel-caption">

                        </div>
                    </div>
                </div>

                <!-- Controls -->
                <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>

        <!--内容-->
        <table class="HP_news">
            <tr>
                <td rowspan="2" style="width: 50%">
                    <div class="huodong">
                        <a class="biaoti" href="jingcaihuodong.html">往期活动</a>
                        <hr style="border:0;background-color:#777;height:1px;" />
                        <ul>
                            <li><a href="nanbei.html">广交社团部南北联欢会</a></li>
                            <li><a href="pinshu.html">协会聘书颁发大会</a></li>
                            <li><a href="#">好好学习天天向上</a></li>
                            <li><a href="#">天气降温注意保暖</a></li>
                            <li><a href="#">这是一条空链接</a></li>
                            <li><a href="#">这是一条空链接</a></li>
                            <li><a href="#">这是一条空链接</a></li>
                        </ul>
                    </div>
                </td>
                <td style="width: 50%">
                    <div class="fengcai">
                        <a class="biaoti" href="shetuanfengcai.html">社团简介</a>
                        <hr style="border:0;background-color:#777;height:1px;" />
                        <p><%=Session["LoginUser"] %></p>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="chengyuan">
                        <a class="biaoti" href="chengyuanjingying.html">成员介绍</a>
                        <hr style="border:0;background-color:#777;height:1px;" />
                        <p>
                            曹操<br />
                            部长：18级软件技术
                        </p>
                        <br />
                        <p>
                            司马懿<br />
                            副部长:18级软件技术
                        </p>
                    </div>
                </td>
            </tr>
        </table>

        <!--其他社团-->
        <footer class="HP_partner hidden-xs">
            <h3>其他社团</h3>
            <div class="container">
                <div class="row">
                    <div class="parlist">
                        <ul>
                            <li class="fa fa-4x"><a href="common/son/Visitor.html"><img src="common/images/logo.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="common/son/yumaoqiu.html"><img src="common/images/yumaoqiu.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="common/son/zhixie.html"><img src="common/images/zhixie.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="common/son/zhaoxuan.html"><img src="common/images/zhaoxuan.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="common/son/pingpangqiu.html"><img src="common/images/pingpangqiu.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="#"><img src="common/images/logo.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="#"><img src="common/images/logo.jpg " style="width: 80px;height: 80px" /></a></li>
                            <li class="fa fa-4x"><a href="#"><img src="common/images/logo.jpg " style="width: 80px;height: 80px" /></a></li>
                        </ul>
                    </div>
                </div>
            </div>


        </footer>
        <!--<script>-->
        <!--function ct() {-->
        <!--return document.compatMode == "BackCompat" ? document.body.clientHeight : document.documentElement.clientHeight;-->
        <!--}-->
        <!--var f = document.getElementsByClassName('HP_partner');-->
        <!--(window.onresize = function () {-->
        <!--f.style.position = document.body.scrollHeight > ct() ? '' : 'absolute';-->
        <!--})();-->
        <!--</script>-->
        <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
        <script src="common/lib/jquery/jquery.min.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
        <script src="common/lib/bootstrap/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
