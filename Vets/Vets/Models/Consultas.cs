﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Consultas{

        [Key]
        public int ID { get; set; }

        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        // FK para Animais
        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; } // Consulta ---> Animal
        public Animais Animal { get; set; }
        // FK para Veterinários
        [ForeignKey(nameof(Veterinario))]
        public int VeterinarioFK { get; set; } // Consulta ---> Veterinarios
        public Veterinarios Veterinario { get; set; }

    }
}
