var chartUtilities = (function () {
    function getChartConfig() {
        return {
            scaleOverride: true,
            scaleSteps: 5,
            scaleStartValue: 0,
            scaleStepWidth: 2,
            scaleLineColor: "rgba(0,0,0,0.1)",
            scaleLineWidth: 2,
            scaleShowLabels: true,
            responsive: true
        };
    }

    function getChartLanguageData(item) {
        return {
            labels: ["Tutorials Watched", "Work on Projects", "Problems Solved"],
            datasets: [
                {
                    label: "Experience",
                    fillColor: "rgba(255, 106, 0, 0.5)",
                    strokeColor: "rgba(255, 106, 0, 0.6)",
                    pointColor: "rgba(255, 106, 0, 1)",
                    pointStrokeColor: "#000000",
                    pointHighlightFill: "#ffffff",
                    pointHighlightStroke: "rgba(255, 106, 0, 0.7)",
                    data: [item.TutorialsWatchedScore, item.WorkOnBiggerProjectsScore, item.ProblemsSolvedScore]
                }
            ]
        };
    }

    function getChartFrameworkData(item) {
        return {
            labels: ["Tutorials Watched", "Work on Projects", "Problems Solved"],
            datasets: [
                {
                    label: "Experience",
                    fillColor: "rgba(255, 106, 0, 0.5)",
                    strokeColor: "rgba(255, 106, 0, 0.6)",
                    pointColor: "rgba(255, 106, 0, 1)",
                    pointStrokeColor: "#000000",
                    pointHighlightFill: "#ffffff",
                    pointHighlightStroke: "rgba(255, 106, 0, 0.7)",
                    data: [item.TutorialsWatchedScore, item.WorkOnBiggerProjectsScore, item.ProblemsSolvedScore]
                }
            ]
        };
    }

    return {
        getChartConfig: getChartConfig,
        getChartLanguageData: getChartLanguageData,
        getChartFrameworkData: getChartFrameworkData
    }
})();