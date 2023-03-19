function SwalFire(icon,title,text,buttonClass,buttonText) {
    Swal.fire({
        title: title,
        text: text,
        icon: icon,
        customClass: {
            confirmButton: buttonClass
        },
        confirmButtonText: buttonText,
        buttonsStyling: false
    });
} 