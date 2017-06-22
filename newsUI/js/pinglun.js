function Chat() {
    var Tb = document.getElementById("TbChat");
    //				若输入内容为空,给提示
    if (Tb.value == "") {
        alert("请输入发言内容");
        return;
    }
    document.getElementById("ChatArea").innerHTML += (Tb.value + "<br />");
    //				document.getElementById("ChatArea").innerText +=(Tb.value + "<br />");
}