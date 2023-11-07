const knex = require('../services/conexao');

const buscarUsuarioPorID = async (id) => {
  return knex('tabelateste').where({ id }).first();
};

const cadastrarUsuario = async (name,phone,email) =>{
  return knex('tabelateste').insert({name,phone,email})
};

const atualizarDadosUsuario = async (id,name,phone,email) =>{
  return knex('tabelateste').update({name,phone,email}).where({id});
};


const excluirDadosUsuario = async (id) =>{
  return knex('tabelateste').delete().where({id});
};

module.exports = {
  buscarUsuarioPorID,
  cadastrarUsuario,
  atualizarDadosUsuario,
  excluirDadosUsuario
};