function libraryListOfBooks(libObj) {
    var booksList = libObj.books;
    var listOfTitles=[];

    for (let index = 0; index < booksList.length; index++) {
        listOfTitles.push(booksList[index].title);  
    }

    return listOfTitles;
}


var library = {
    books:[
        {
            title : 'عودة الروح',
            author : 'توفيق الحكيم',
            year:'1933'
            
        },
        {
            title : ' ثرثرة فوق النيل',
            author : 'نجيب محفوظ',
            year:'1966'
            
        },
        {
            title : 'يوتوبيا',
            author : 'أحمد خالد توفيق',
            year:'2008'
            
        }
    ]
};



document.writeln(
    `<h1> لديك في المكتبة مجموعة كتب بالعناوين الاتية</h1><br>`,
    `<h2> ${libraryListOfBooks(library)}</h2><br>`
);
