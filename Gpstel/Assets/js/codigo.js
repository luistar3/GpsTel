$('.modal').on('shown.bs.modal', function () {
    //To relate the z-index make sure backdrop and modal are siblings
    $(this).before($('.modal-backdrop'));
    //Now set z-index of modal greater than backdrop
    $(this).css("z-index", parseInt($('.modal-backdrop').css('z-index')) + 1);

});

