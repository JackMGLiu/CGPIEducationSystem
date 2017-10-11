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