/*
1. doboz:
Kattintásra adjunk hozzá egy "blur" nevű class attribútumot, majd újabb kattintásra vegyük
le róla azt.
*/
document.getElementById("element-one").onclick = function () {
  document.getElementById("element-one").classList.toggle("blur");
}

/*
2. doboz:
Ha az egérrel fölé megyünk változzon meg a háttérszíne pirosra, ha levesszük róla az egeret
változzon vissza az eredeti színére.
*/
document.getElementById("element-two").onmouseenter = function () {
  document.getElementById("element-two").style.backgroundColor = "red";
}
document.getElementById("element-two").onmouseleave = function () {
  document.getElementById("element-two").style.backgroundColor = "";
}

/*
3. doboz:
Dupla kattintással sorsoljon egy számot 1 és 20 között és módosítsa a kapott számmal a doboz tartalmát. 
*/
document.getElementById("element-three").ondblclick = function () {
  document.getElementById("element-three").innerHTML = '<span class="text">' + Math.floor(Math.random() * (20 - 1 + 1) + 1) + '</span>';
}

/*
4. doboz:
Kattintásra tűnjön el, majd egy 1 másodperces várakozás után ismét jelenjen meg.
*/
document.getElementById("element-four").onclick = function () {
  document.getElementById("element-four").classList.add("hidden");
  setTimeout(() => {
    document.getElementById("element-four").classList.remove("hidden");
  }, 1000);
}

/*
5. doboz:
Kattintásra alakítsa kör alakúra az összes dobozt.
*/
document.getElementById("element-four").onclick = function () {
  let shapes = document.getElementsByClassName("shape");
  for (const shape of shapes) {
    shape.style.borderRadius = "50%";
  }
}

/*
6. doboz:
Form submit eseményre módosítsuk a doboz tartalmát az input mezőbe írt értékkel
*/



/*
7. doboz:
Keypress eseményre írjuk be a dobozba az adott karaktert, amit leütöttek
*/
document.getElementById("box7-input").onkeydown = function (event) {
  document.getElementById("element-seven").children[0].innerHTML = event.key
}

/*
8. doboz:
Egérmozdítás eseményre írjuk be az egér pozíciójának x és y koordinátáját, 
a következő séma szerint: "X: {x-koordináta}, Y: {y-koordináta}"
*/
document.onmousemove = function (event) {
  document.getElementById("element-eight").children[0].innerHTML = event.clientX + " " + event.clientY
}

/*
9. doboz:
Submit eseményre módosítsuk a doboz tartalmát azzal az értékkel ami úgy áll elő, 
hogy végrehajtjuk a select inputban kiválasztott operációt,
a state-en és number inputba beírt értéken.
Az előállt végeredményt tároljuk el új state-ként!
Pl:
  Number input mezőbe írt érték: 5
  Select inputban kiválasztott érték: "mult"
  Aktuális state: 9
  Operáció: 9 * 5
  
  Dobozba és state-be beírandó érték: 45
*/