using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wineHandler.Models;

public class Load
{
    public readonly WineHandlerContext _context;

    public Load(WineHandlerContext context)
    {
        _context = context;
    }

    public void Appellations(ComboBox comboBoxAppellation)
    {
        var appellations = _context.Appellations
            .OrderBy(a => a.Nom)
            .ToList();

        comboBoxAppellation.DisplayMember = "Nom";
        comboBoxAppellation.ValueMember = "IdAppellation";
        comboBoxAppellation.DataSource = appellations;
        comboBoxAppellation.SelectedIndex = -1;
    }

    public void Caves(ComboBox comboBoxCave)
    {
         var caves = _context.Caves
        .OrderBy(c => c.Nom)
        .ToList();

        comboBoxCave.DisplayMember = "Nom";
        comboBoxCave.ValueMember = "IdCave";
        comboBoxCave.DataSource = caves;
        comboBoxCave.SelectedIndex = -1;
    }

    public void CavesGrid(DataGridView grid)
    {
        var caves = _context.Caves
       .OrderBy(c => c.Nom)
        .ToList();
        grid.DataSource = caves;
    }
}

