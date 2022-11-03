
var product = [
    {
        name: "Asus",
        id: Number(13),
        price: Number(2000)

    },
    {

        name: "lenovo",
        id: Number(9),
        price: Number(3000)

    },
    {

        name: "acer",
        id: Number(12),
        price: Number(1500)

    },
    {

        name: "hp",
        id: Number(34),
        price: Number(2300)

    },
    {
        name: "msi",
        id: Number(22),
        price: Number(2100)

    }

]
var say = Number()
var sum = Number()



for (var i = 0; i < product.length; i++) {
    
    if (product[i].id % 2 != 0) {
        say++;
        sum += product[i].price
        var edediorta = Number( sum/say) 
        

    }
}
console.log(edediorta);














