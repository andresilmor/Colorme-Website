
// TEXTO DINÂMICO (Index)

function nextMsg() {
    if (messages.length == 0) {
        messages = [
            "Colorme",
            "Personalização"
        ].reverse();
    }
    $('#mensagemCapaTextoDinamico').html(messages[messages.length - 1]).fadeIn(500).delay(2500).fadeOut(500, nextMsg);
    messages.pop();

};

var messages = [
    "Colorme",
    "Personalização"
].reverse();

nextMsg();

//setLinkAsSelected("principal");

function setLinkAsSelected(link) {
    console.log('#nav-' + link);
    $('#nav-' + link).css('color', '#F7B733');
};
