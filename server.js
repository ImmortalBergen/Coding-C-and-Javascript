
const os = require('os');
const fs = require('fs');
const rl = require('readline');
const http = require('http');
const bodyParser = require('body-parser');
const express = require('express');
const app = express();
const path = require('path');
const router = express.Router();
const socket = require('socket.io');
const drone = require('ar-drone');
const exec = require('child_process');

server1 = http.createServer(function(req, res) {
    fs.writeFile('Commands.txt', "1", function(err) {
        if (err) return console.log(err);
    })
    res.writeHead(200, {"Content-Type": "type/text"});
    res.write("Licht wurde angeschalten");
    res.end();
           
});

server2 = http.createServer(function(req, res) {
    fs.writeFile('Commands.txt', "0", function(err) {
        if (err) return console.log(err);
    })
    res.writeHead(200, {"Content-Type": "type/text"});
    res.write("Licht wurde ausgeschalten");
    res.end();
           
});

server1.listen(8080, '0.0.0.0');
server2.listen(3000, '0.0.0.0')  
console.log('Servers are now listening...');