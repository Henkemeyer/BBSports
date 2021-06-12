require('./crud/User');
const express = require('express');
const mongoose = require('mongoose');
const authRoutes = require('./mongo/authRoutes');
const requireAuth = require('./middleware/requireAuth');

// import React from 'react';
// import { View, Text, StyleSheet } from 'react-native';

const app = express();

app.use(express.json());
app.use(express.urlencoded());
app.use(authRoutes);

const mongoUri = "mongodb+srv://appUser:H6ZZoqoB9Ah6pMmM@bbdev.lrn84.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
mongoose.connect(mongoUri, {
    useNewUrlParser: true,
    useCreateIndex: true,
    useUnifiedTopology: true
});

mongoose.connection.on('connected', () => {
    console.log('Connected to mongo instance');
});

mongoose.connection.on('error', (err) => {
    console.error('Error connecting to mongo', err);
});

app.get('/', requireAuth, (req, res) => {
    res.send(`Your Email: ${req.user.email}`);
});

app.listen(3000, () => {
    console.log('Listening on port 3000');
});