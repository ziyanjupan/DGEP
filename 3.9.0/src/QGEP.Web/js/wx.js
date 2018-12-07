var dghb_submit = document.getElementsByClassName('dghb_submit')[0];
dghb_submit.onclick = function () {
    //获取用户输入的值
    var community = $('.community').val();
    var roomNumber = $('.roomNumber').val();
    var number = $('.number').val();
    var remark = $('.remark').val();
    var dghb_time = $('.dghb_time_txt').val();
    //校验，给出输入为空或格式报错提示


    //发送数据给后端，将数据存入数据库
    $.ajax({
        async: false,
        type: 'POST',   //提交的方式
        url: '/Invite/Submit',  //传递到服务器的url
        data: {    //发送的数据，以JSON数据传递
            community: community,//小区
            roomNumber: roomNumber,//房号
            number: number,//电话
            remark: remark,//备注
            dghb_time: dghb_time,//服务时间
        },
        success: function (json) {   //成功之后执行的函数
            console.log(json);
            if (json.code === 200) {
                //成功之后

            }
        }
    });
}