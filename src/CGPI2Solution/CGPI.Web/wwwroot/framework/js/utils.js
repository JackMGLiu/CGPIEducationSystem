/** kit_admin-v1.0.9 MIT License By http://kit/zhengjinfan.cn e-mail:zheng_jinfan@126.com */
 ;
 layui.define(["layer"],
     function(n) {
         var t = layui.jquery, e = layui.layer;
         n("utils",
         {
             v: "1.0.2",
             getBodyContent: function(n) {
                 var t = /<body[^>]*>([\s\S]*)<\/body>/.exec(n);
                 return t && 2 === t.length ? t[1] : n;
             },
             loadHtml: function(n, e) {
                 var o;
                 return t.ajax({
                     url: n,
                     async: !1,
                     dataType: "html",
                     error: function(t, e, i) {
                         var r = [
                             '<div style="padding: 20px;font-size: 20px;text-align:left;color:#009688;">',
                             "<p>{{msg}}  >>> " + n + "</p>", "</div>"
                         ].join("");
                         o = 404 !== t.status
                             ? r.replace("{{msg}}", '<i class="layui-icon" style="font-size:70px;">&#xe69c;</i>  未知错误.')
                             : r.replace("{{msg}}", '<i class="layui-icon" style="font-size:70px;">&#xe61c;</i>  ' + i);
                     },
                     success: function(n) { o = n },
                     complete: function() { "function" == typeof e && e() }
                 }), o;
             },
             load: function(n) { return n = n || 0, e.load(n, { shade: [.3, "#333"] }) },
             post: function(n, o, i) {
                 t.post(n,
                     o,
                     function(n) {
                         101 === n.statusCode &&
                             e.alert(n.msg,
                                 {
                                     icon: 2,
                                     title: "系统提示",
                                     cancel: function(n, t) { top.location.href = location.origin + "/login" }
                                 },
                                 function() { top.location.href = location.origin + "/login" }), i(n);
                     },
                     "json");
             },
             get: function(n, o, i) {
                 t.getJSON(n,
                     o,
                     function(n) {
                         101 === n.statusCode &&
                             e.alert(n.msg,
                                 {
                                     icon: 2,
                                     title: "系统提示",
                                     cancel: function(n, t) { top.location.href = location.origin + "/login" }
                                 },
                                 function() { top.location.href = location.origin + "/login" }), i(n);
                     });
             },
             keyWordHighlight: function(n, t, e, o) {
                 function i(n, t) {
                     function e(n, t) {
                         switch (arguments.length) {
                         case 1:
                             return parseInt(Math.random() * n + 1);
                         case 2:
                             return parseInt(Math.random() * (t - n + 1) + n);
                         default:
                             return 0;
                         }
                     }

                     function o(n, t, e) {
                         for (var o = "", i = 0; i < e; o += t, i++);
                         return o = (o += n).substr(o.length - e);
                     }

                     if (1 == arguments.length) {
                         t = n;
                         n = 0;
                     } else if (0 == arguments.length) var n = 0, t = 255;
                     var i = e(n, t).toString(16);
                     i = o(i, i, 2);
                     var r = e(n, t).toString(16);
                     r = o(r, r, 2);
                     var a = e(n, t).toString(16);
                     return a = o(a, a, 2), "#" + i + r + a;
                 }

                 var r = fgCor = "";
                 e ? (r = i(10, 20), fgCor = i(230, 255)) : (r = "transparent", fgCor = "red");
                 for (var a = new RegExp(t, "i"), c = 0; c < n.childNodes.length; c++) {
                     var l = n.childNodes[c], s = l.parentNode;
                     if (1 == l.nodeType) this.keyWordHighlight(l, t, e, o);
                     else if (3 == l.nodeType && "A" != s.nodeName) {
                         if (-1 == l.data.search(a)) continue;
                         var u = function(n, t) {
                             var e = ' style="background-color:' + r + ";color:" + fgCor + ';" ',
                                 i = document.createElement("span"),
                                 a = "",
                                 c = new RegExp("(" + t + ")", "gi");
                             return a = o
                                 ? n.replace(c, '<a href="' + o + '$1"' + e + ">$1</a>")
                                 : n.replace(c, "<span " + e + ">$1</span>"), i.innerHTML = a, i;
                         }(l.data, t);
                         s.replaceChild(u, l);
                     }
                 }
             }
         });
     });