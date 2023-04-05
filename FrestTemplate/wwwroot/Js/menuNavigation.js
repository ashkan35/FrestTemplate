window.setActiveMenu = function (urlSegment) {
    const activeOrOpenItems = document.querySelectorAll('.menu-inner li.active, .menu-inner li.open');
    for (var i = 0; i < activeOrOpenItems.length; i++) {
        activeOrOpenItems[i].classList.remove('active');
        activeOrOpenItems[i].classList.remove('open');
    }


    const query = `a[href="${urlSegment}"]`;
    const link = document.querySelector(query);
    const li = link.closest('li');
    if (li) {
        li.classList.add('active');
    }
    const parents = $(link).parentsUntil('.menu-inner', 'li:not(:first)');
    if (parents) {
        for (var i = 0; i < parents.length; i++) {
    
            parents[i].classList.add('open');


        }

    }
}