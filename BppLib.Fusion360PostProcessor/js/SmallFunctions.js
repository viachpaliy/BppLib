/** */
function getProperty(name) { return (properties[name] != undefined ? properties[name].value : null);}

function getAsInt(value){return Number(value);}



function getNumberOfSections() {return 1;}

function writeWords(a0, a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "", a7 = "", a8 = "", a9 = "", a10 = "", a11 = ""){
    var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
    writeln(args.join(''));}

function formatWords(arguments){
    var result = "";
    var args = Array.prototype.slice.call(arguments, 1);
    result += args.join("");
    return result;}

function writeWords2(a0, a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "", a7 = "", a8 = "", a9 = "", a10 = "", a11 = ""){
    var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
    writeln(args.join(''));}

function conditional(a0, a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "", a7 = "", a8 = "", a9 = "", a10 = "", a11 = ""){
    var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
    return(args.join(''));}

    function subst(a0, a1 = "", a2 = "", a3 = "") {
        let str = a0;
        if (a1 != "") {str.replace("%1", a1);}
        if (a2 != "") {str.replace("%2", a2);}
        if (a3 != "") {str.replace("%3", a3);}
        return str;
    }

    function is3D(){return false;}
