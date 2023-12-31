require('dotenv').config();

const knex = require('knex')({
    client: 'pg',
    connection: {
      host: process.env.DB_URL,
      port: process.env.DB_PORT,
      user: process.env.DB_USER,
      password: process.env.DB_PASS,
      database: process.env.DB_NAME,
    },
    searchPath: ['knex', 'public'],
    pool: { min: 0, max: 7 },
  });
  
  module.exports = knex;
  