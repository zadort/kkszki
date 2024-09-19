//1. feladat
const szam1 = Number(prompt("adj meg egy szamot"));
const szam2 = Number(prompt("adj meg egy masik szamot"));
const hatvany = szam1 ** szam2;
console.log(hatvany);

//2. feladat
let uzenet = "Szia";
const nev = prompt("add meg a neved");
console.log(uzenet + " " + nev + "!");

//3. feladat
const szam = Math.floor(Math.random() * (10 - 1 + 1)) + 1;
const eredmeny = (szam > 5) ? "Nagyobb" : "Nem nagyobb";
console.log(eredmeny);

//4. feladat
const szam3 = Number(prompt("adj meg egy szamot"));
const abszolut = Math.abs(szam3);
console.log(abszolut);

//5. feladat
const szam4 = Number(prompt("adj meg egy szamot"));
const negyzetgyok = Math.sqrt(szam4);
console.log(negyzetgyok);

//6. feladat
const a = Number(prompt("add meg az a oldalt"));
const ma = Number(prompt("add meg az a magassagat"));
const terulet = (a * ma) / 2;
console.log(terulet);
