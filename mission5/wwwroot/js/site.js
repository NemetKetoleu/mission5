$(document).ready(function () {
    $('#calculateBtn').click(function () {
        var hours = $('#hours').val();
        var hourlyRate = $('#hourly-rate').val();

        if (hours > 0) {
            var total = hours * hourlyRate;
            $('#total-output').text('$' + total.toFixed(2));
        } else {
            alert('Please enter a positive number of hours.');
        }
    });
});
