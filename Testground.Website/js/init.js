initialize = function (barChartData, canvas) {
	var ctx = document.getElementById(canvas).getContext("2d");
	window.myBar = new Chart(ctx).Bar(barChartData, {
		responsive: true,
		multiTooltipTemplate: "<%= value %> ms",
		legendTemplate: "<ul class=\"<%=name.toLowerCase()%>-legend\"><% for (var i=0; i<datasets.length; i++){%><li><span style=\"background-color:<%=datasets[i].strokeColor%>\"><%if(datasets[i].label){%><%=datasets[i].label%><%}%></span></li><%}%></ul>"
	});
}