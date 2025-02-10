
$(document).ready(function () {
    // Handle the button click to calculate the total cost
    $('#btnCalculate').click(function () {
        // Get the number of hours from the input field
        let hours = $('#txtHours').val();
        // Get the charge per hour (it's fixed at 50 for this example)
        let charge = $('#txtCharge').val();

        // Validate the input to make sure it's a valid number greater than 0
        if (hours && hours > 0) {
            // Calculate the total cost
            let total = hours * charge;
            // Display the total in the output field
            $('#txtTotal').val(total.toFixed(2)); // Show total with 2 decimals
        } else {
            // If the user input is invalid, show an alert
            alert("Please enter a valid number of hours.");
        }
    });
});
