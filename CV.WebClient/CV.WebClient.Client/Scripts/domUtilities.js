var domUtilities = (function () {
    function getAndInsertItemsCollection(requestURL, container, itemHref) {
        var $docFragment = $(document.createDocumentFragment());

        $.ajax({
            type: "GET",
            url: requestURL
        })
        .done(function (collection) {
            for (var item in collection) {
                var $item = $('<div />'),
                    $anchor = $('<a />'),
                    currentItem = collection[item];

                $anchor.attr('href', itemHref + currentItem.Id);
                $item.text(currentItem.Name);

                $item.addClass('icon');
                $item.addClass('framework-icon');

                $anchor.append($item);

                $docFragment.append($anchor);
            }

            container.append($docFragment);
        });
    }

    function getAndInsertCanvasGraphic(requestURL, container) {
        var $docFragment = $(document.createDocumentFragment());

        $.ajax({
            type: "GET",
            url: requestURL
        })
        .done(function (dataInfo) {
            var $heading = $('<h3 />'),
                $canvasWrapper = $('<div />'),
                $canvas = $('<canvas />');

            $canvas.attr("id", "canvas-graphic");

            $canvasWrapper.addClass('canvas-wrapper');

            $heading.text(dataInfo.Name);

            $canvasWrapper.append($canvas);

            $docFragment.append($heading);
            $docFragment.append($canvasWrapper);

            container.append($docFragment);

            var chartDataInfo = chartUtilities.getChartLanguageData(dataInfo);

            var ctx = document.getElementById("canvas-graphic").getContext("2d");
            var chart = new Chart(ctx).Radar(chartDataInfo, chartUtilities.getChartConfig());
        });
    }

    return {
        getAndInsertItemsCollection: getAndInsertItemsCollection,
        getAndInsertCanvasGraphic: getAndInsertCanvasGraphic
    };
})();