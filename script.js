
//Lógica-->
function SortearNumero(){
    let numSorteado = Math.floor(Math.random()*50)+1;
    return numSorteado;
}


function GenerarPista(numIngresado){
  
    if(numIngresado==numSorteado){
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
    numSorteado=SortearNumero();
    let score=100;

    sessionStorage.setItem("numSorteado",numSorteado);

    let highScore= document.cookie;

    document.querySelector("#score").textContent=score;
    document.querySelector("#numSorteado").textContent=numSorteado;
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
             document.querySelector("#mensaje").textContent="Game Over!";
             document.querySelector("#numIngresado").style.display="none";
             document.querySelector("#btnEnviar").style.display="none";
         }
 
         document.querySelector("#score").textContent=scoreActualizado;
    }else{
         let nuevoScore = Number(document.querySelector("#score").textContent);
         let highScore=document.cookie;
 
         if(nuevoScore>highScore){
             document.cookie=nuevoScore;
             document.querySelector("#highScore").textContent=nuevoScore;
         }
 
         document.querySelector("#numIngresado").style.display="none";
         document.querySelector("#btnEnviar").style.display="none";
    }

}
//Eventos-->
document.querySelector("#btnIniciar").onclick = () => {
    IniciarJuego();
  }

document.querySelector("#btnEnviar").onclick = () => {

   let numIngresado = document.querySelector("#numIngresado").value;
   let pista = GenerarPista(numIngresado);
   AsignarNuevoScore(pista);
   document.querySelector("#numIngresado").value="";
   document.querySelector("#mensaje").textContent=pista;
   
  
}

document.querySelector("#btnReiniciar").onclick=()=>{
    NuevoJuego();
}