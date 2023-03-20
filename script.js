
//Lógica-->
function SortearNumero(){
    let numSorteado = Math.floor(Math.random()*50)+1;
    return numSorteado;
}


function GenerarPista(numIngresado){
    if(numIngresado==""){
        mensaje="Por favor ingresa un número" ;
    }
    else if(numIngresado==numSorteado){
        mensaje="Adivinaste!" ;
    }
    else if(numIngresado>numSorteado){
        mensaje="Muy alto!";
    } else{
        mensaje="Muy bajo!";
    }  
    return mensaje;
}

function DescontarPuntos(score){
    score-=5;
    return score;
}


//Pantalla-->

function IniciarJuego(){
    
    document.querySelector("#juego").style.display="block";
    document.querySelector("#btnIniciar").style.display="none";
   
    numSorteado=SortearNumero();
    let score=100;

    sessionStorage.setItem("numSorteado",numSorteado);
    let highScore=document.cookie;

    document.querySelector("#score").textContent=score;
    document.querySelector("#numSorteado").textContent=numSorteado;
    document.querySelector("#numSorteado").style.visibility="hidden";
    document.querySelector("#highScore").textContent=highScore;
}

function NuevoJuego(){
    location.reload();
}



function AsignarNuevoScore(pista){

    score=Number(document.querySelector("#score").textContent);

    if(pista!="Adivinaste!" ){
        let scoreActualizado=DescontarPuntos(score);
        if(scoreActualizado==0){
            var audio = document.getElementById("audioGameover");
            audio.play();
            document.querySelector("#gameover").style.display="block";
            document.querySelector("#numSorteado").style.visibility="visible";
            document.querySelector("#numIngresado").style.display="none";
            document.querySelector("#btnEnviar").style.display="none";
            document.querySelector("#instrucciones").style.visibility="hidden"
            document.querySelector("#mensaje").style.visibility="hidden";
            
        }
 
        document.querySelector("#score").textContent=scoreActualizado;
    }
    else{
        var audio = document.getElementById("audioWin");
        audio.play();
        let nuevoScore = Number(document.querySelector("#score").textContent);
        let highScore=document.cookie;
 
        if(nuevoScore>highScore){
            document.cookie=nuevoScore;
            document.querySelector("#highScore").textContent=nuevoScore;
        }
     document.querySelector("#win").style.display="block";
     document.querySelector("#numSorteado").style.visibility="visible";
     document.querySelector("#numIngresado").style.display="none";
     document.querySelector("#btnEnviar").style.display="none";
     document.querySelector("#instrucciones").style.visibility="hidden"
     document.querySelector("#mensaje").style.visibility="hidden";
    }

}
//Eventos-->

function validaNumericos(event) {
    if(event.charCode >= 48 && event.charCode <= 57){
      return true;
     }
     return false;        
}

document.querySelector("#btnIniciar").onclick = () => {
    
    document.getElementById("principal").style.backgroundColor ="#450e9d";
    document.getElementById("btnReiniciar").style.visibility="visible";
    IniciarJuego();
    
  }

document.querySelector("#btnEnviar").onclick = () => {

   let numIngresado = document.querySelector("#numIngresado").value;
   let pista = GenerarPista(numIngresado);
   AsignarNuevoScore(pista);
   document.querySelector("#numIngresado").value="";
   document.querySelector("#mensaje").textContent=pista;
   document.querySelector("#scores").style.visibility="visible";
   
  
}

document.querySelector("#btnReiniciar").onclick=()=>{
    NuevoJuego();

}


