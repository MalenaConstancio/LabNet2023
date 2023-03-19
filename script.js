
//Lógica-->
function SortearNumero(){
    let numSorteado = Math.floor(Math.random()*50)+1;
    return numSorteado;
}


function GenerarPista(numIngresado){
  
    if(numIngresado==numSorteado){
        mensaje="Adivinaste!" 
    }
    else if(numIngresado>numSorteado){
        mensaje="Muy alto!"
    } else{
        mensaje="Muy bajo!"
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

    sessionStorage.setItem("numSorteado",numSorteado);
    sessionStorage.getItem("highScore",highScore); //cambiar por una cookie

    document.querySelector("#numSorteado").textContent=numSorteado;
    document.querySelector("#highScore").textContent=highScore;
}

function NuevoJuego(){
    location.reload();
}

//Eventos-->
document.querySelector("#btnIniciar").onclick = () => {
    IniciarJuego();
  }

document.querySelector("#btnEnviar").onclick = () => {

   let numIngresado = document.querySelector("#numIngresado").value;
   let pista = GenerarPista(numIngresado);
   document.querySelector("#numIngresado").value="";
   document.querySelector("#mensaje").textContent=pista;
}

document.querySelector("#btnReiniciar").onclick=()=>{
    NuevoJuego();
}