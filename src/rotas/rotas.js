
const { Router } = require('express');
const usuario = require("../controller/usuario")

const rotasUsuario = Router();

rotasUsuario.get("/", usuario.detalharUsuario)

rotasUsuario.post("/inserir", usuario.cadastrarUsuario);

rotasUsuario.post("/atualizar", usuario.AtualizarUsuario);


rotasUsuario.post("/excluir", usuario.ExcluirUsuario);

module.exports = {

    rotasUsuario
};