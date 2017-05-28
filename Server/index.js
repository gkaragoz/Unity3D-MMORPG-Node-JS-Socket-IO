var express = require('express');
var app		= express();

var server	= require('http').createServer(app);
var io		= require('socket.io').listen(server);

app.set('port', process.env.PORT || 3000);



server.listen(app.get('port'), function(){
	console.log("-------- SERVER IS RUNNING --------");
});