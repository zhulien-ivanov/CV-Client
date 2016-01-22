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

    function getAndInsertCertificates(requestURL, container) {
        var $docFragment = $(document.createDocumentFragment());

        $.ajax({
            type: "GET",
            url: requestURL
        })
        .done(function (certificates) {
            var $docFragment = $(document.createDocumentFragment()),
                certificatesCount = certificates.length,
                columnLength = 3;

            for (var i = 0; i < certificatesCount; i += 3) {
                var $rowDiv = $('<div />');

                $rowDiv.addClass('row');

                if (certificatesCount - i < columnLength) {
                    columnLength = certificatesCount - i;
                }

                for (var j = i; j < i + columnLength; j++) {
                    var $columnDiv = $('<div />'),
                        $anchor = $('<a />'),
                        $heading = $('<h4 />'),
                        $image = $('<img />');

                    $columnDiv.addClass('col-md-4');

                    $heading.text(certificates[j].Name);

                    $image.attr('src', certificates[j].ImageLocation);
                    $image.attr('alt', certificates[j].Name);

                    $anchor.addClass('thumbnail');
                    $anchor.attr('href', certificates[j].URL);

                    $anchor.append($heading);
                    $anchor.append($image);

                    $columnDiv.append($anchor);

                    $rowDiv.append($columnDiv);
                }

                $docFragment.append($rowDiv);
            }

            container.append($docFragment);
        });
    }

    return {
        getAndInsertItemsCollection: getAndInsertItemsCollection,
        getAndInsertCanvasGraphic: getAndInsertCanvasGraphic,
        getAndInsertCertificates: getAndInsertCertificates
    };
})();