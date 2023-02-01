

// Uses jquery to get inputs, calculate grade, and output results
$("#buttomSub").click(function () {

    // Getting inputs
    var assignment = $('#assignment').val();
    var gproject = $('#gproject').val();
    var quizzes = $('#quizzes').val();
    var midterm = $('#midterm').val();
    var final = $('#final').val();
    var intex = $('#intex').val();

    // Calculating Grade
    var total = (assignment * .5) + (gproject * .1) + (quizzes * .1) + (midterm * .1) + (final * .1) + (intex * .1);
    var grade = "";

    // Determining Numeric Grade
    if (total >= 94)
        grade = 'A';
    else if (total >= 90)
        grade = 'A-';
    else if (total >= 87)
        grade = 'B+';
    else if (total >= 84)
        grade = 'B';
    else if (total >= 80)
        grade = 'B-';
    else if (total >= 77)
        grade = 'C+';
    else if (total >= 74)
        grade = 'C';
    else if (total >= 70)
        grade = 'C-';
    else if (total >= 67)
        grade = 'D+';
    else if (total >= 64)
        grade = 'D';
    else if (total >= 60)
        grade = 'D-';
    else
        grade = 'E';

    // Displaying results to empty paragraph on DOM
    $('#results').text('Numeric Grade: ' + total + '%\nLetter Grade: ' + grade)
})
