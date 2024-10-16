package com.ejemplo.demo.controllers;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HolaMundoController {

    @GetMapping("/hola")
    public String decirHola() {
        return "Hola Mundo";
    }
}