function SwalFire(text,title,icon,buttonClass,buttonText,buttonsStyling=false) {
    Swal.fire({
        title: 'خطا!',
        text: ' شما روی دکمه کلیک کردید!',
        icon: 'error',
        customClass: {
            confirmButton: 'btn btn-primary'
        },
        confirmButtonText: 'باشه',
        buttonsStyling: false
    });
} 