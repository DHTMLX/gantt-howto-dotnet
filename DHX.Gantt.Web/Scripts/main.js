document.addEventListener("DOMContentLoaded", function () {
    gantt.config.order_branch = true;
    gantt.config.order_branch_free = true;

    // add month scale
    gantt.config.scale_unit = "month";
    gantt.config.step = 1;
    gantt.config.date_scale = "%M %Y";
    gantt.config.subscales = [
        { unit: "day", step: 1, date: "%d" }
    ];
    gantt.config.scale_height = 50;

    gantt.config.xml_date = "%Y-%m-%d %H:%i"; // format of dates in XML
    gantt.init("ganttContainer"); // initialize gantt
    gantt.load("/api/data", "json");

    var dp = new gantt.dataProcessor("/api");
    dp.init(gantt);
    dp.setTransactionMode("REST");
});