const express = require('express');
const rota = require('./rotas/rotas');
require('dotenv').config();

const app = express();

app.use(express.json());

app.use(rota.rotasUsuario);

app.listen(process.env.PORT);


