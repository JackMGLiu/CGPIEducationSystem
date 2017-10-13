/**
 * 创建一个信息弹窗。
 * @param {String} content 
 * @param {String} type 
 */
$.layerMsg = function(content, type, callback) {
    //debugger;
    if (type != undefined) {
        var icon = "";
        if (type == 'warning' || type == 0) {
            icon = 0;
        }
        if (type == 'success' || type == 1) {
            icon = 1;
        }
        if (type == 'error' || type == 2) {
            icon = 2;
        }
        if (type == 'info' || type == 6) {
            icon = 6;
        }
        top.layer.msg(content,
            { icon: icon, time: 2000 },
            function() {
                if (callback && $.isFunction(callback)) {
                    callback();
                }
            });
    } else {
        top.layer.msg(content,
            function() {
                if (callback && $.isFunction(callback)) {
                    callback();
                }
            });
    }
};

/**
 * 获取URL指定参数值。
 * @param {String} name
 */
$.getQueryString = function (name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

/**
 * 绑定Select选项。
 * @param {Object} options
 */
$.fn.bindSelect = function(options) {
    var defaults = {
        id: "id",
        text: "text",
        search: true,
        //multiple: false,
        title: "请选择",
        url: "",
        param: [],
        change: null
    };
    var options = $.extend(defaults, options);
    var $element = $(this);
    if (options.url != "") {
        $.ajax({
            url: options.url,
            data: options.param,
            type: "post",
            dataType: "json",
            async: false,
            success: function(data) {
                $.each(data,
                    function(i) {
                        $element.append($("<option></option>").val(data[i][options.id]).html(data[i][options.text]));
                    });
                $element.select2({
                    placeholder: options.title,
                    //multiple: options.multiple,
                    minimumResultsForSearch: options.search == true ? 0 : -1
                });
                $element.on("change",
                    function(e) {
                        if (options.change != null) {
                            options.change(data[$(this).find("option:selected").index()]);
                        }
                        $("#select2-" + $element.attr('id') + "-container")
                            .html($(this).find("option:selected").text().replace(/　　/g, ''));
                    });
            }
        });
    } else {
        $element.select2({
            minimumResultsForSearch: -1
        });
    }
};

/**
 * 绑定Enter提交事件。
 * @param {Object} $event 需要触发的元素或事件。
 */
$.fn.bindEnterEvent = function($event) {
    var $selector = $(this);
    $.each($selector,
        function() {
            $(this).unbind("keydown").bind("keydown",
                function(event) {
                    if (event.keyCode == 13) {
                        if ($.isFunction($event)) {
                            $event();
                        } else {
                            $event.click();
                        }
                    }
                });
        });
};

/**
 * 绑定Change提交事件。
 * @param {Object} $event 需要触发的元素或事件。
 * 
 */
$.fn.bindChangeEvent = function($event) {
    var $selector = $(this);
    $.each($selector,
        function() {
            $(this).unbind("change").bind("change",
                function(event) {
                    if ($.isFunction($event)) {
                        $event();
                    } else {
                        $event.click();
                    }
                });
        });
};

/**
 * 提交表单。
 * @param {Object} options
 */
var msgloading;
$.formSubmit = function(options) {
    var defaults = {
        url: "",
        data: {},
        type: "post",
        async: false,
        success: null,
        close: true,
        showMsg: true,
        winindex:''
    };
    var options = $.extend(defaults, options);
    $.ajax({
        url: options.url,
        data: options.data,
        type: options.type,
        async: options.async,
        dataType: "json",
        success: function(data) {
            if (options.success && $.isFunction(options.success)) {
                options.success(data);
            }
            if (options.close) {
                //$.layerClose();
                layer.close(options.winindex);
            }
            if (options.showMsg) {
                $.layerMsg(data.message, data.state);
            }
        },
        error: function(xhr, status, error) {
            top.layer.close(msgloading);
            $.layerMsg(error, "error");
        },
        beforeSend: function() {
            msgloading = top.layer.msg('正在执行操作，请稍后...',
            {
                icon: 16,
                shade: 0.01
            });
        },
        complete: function() {
            top.layer.close(msgloading);
        }
    });
};

$.isNullOrEmpty = function (obj) {
    if ((typeof (obj) === "string" && obj === "") || obj == null || obj === undefined) {
        return true;
    } else {
        return false;
    }
};