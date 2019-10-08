const MonthList = {
    January: 0,
    February: 1,
    March: 2,
    April: 3,
    May: 4,
    June: 5,
    July: 6,
    August: 7,
    September: 8,
    October: 9,
    November: 10,
    December: 11,
}

dateFuture = new Date(2020, MonthList.February, 29, 0, 0, 0, 0);


function GetCount() {

    miliseconds = new Date().getMilliseconds();
    seconds = new Date().getSeconds();
    minutes = new Date().getMinutes();
    hours = new Date().getHours();
    day = new Date().getDate();
    month = new Date().getMonth();
    year = new Date().getFullYear();

    dateNow = new Date(year, month, day, hours, minutes, seconds, miliseconds);
    //grab current date
    amount = dateFuture.getTime() - (dateNow.getTime());
    //calc milliseconds between dates
    delete dateNow;

    // time is already past
    if (amount < 0) {
        document.getElementById('countbox').innerHTML = "Now!";
    }
    // date is still good
    else {

        days = 0; hours = 0; mins = 0; secs = 0; out = "";

        amount = Math.floor(amount / 1000);//kill the "milliseconds" so just secs

        days = Math.floor(amount / 86400);//days
        amount = amount % 86400;

        hours = Math.floor(amount / 3600);//hours
        amount = amount % 3600;

        mins = Math.floor(amount / 60);//minutes
        amount = amount % 60;

        secs = Math.floor(amount);//seconds

        if (days != 0) { out += days + " day" + ((days != 1) ? "s" : "") + " "; }
        if (days != 0 || hours != 0) { out += hours + " hour" + ((hours != 1) ? "s" : "") + " "; }
        if (days != 0 || hours != 0 || mins != 0) { out += mins + " minute" + ((mins != 1) ? "s" : "") + " "; }
        out += secs + " seconds";
        document.getElementById('countbox').innerHTML = out;

        setTimeout("GetCount()", 1000);
    }
}

window.onload = function () { GetCount(); }//call when everything has loaded

   