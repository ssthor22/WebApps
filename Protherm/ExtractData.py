# -*- coding: utf-8 -*-
"""
Created on Thu Oct  8 23:44:42 2020

@author: Seth
"""
f = open("Protherm.txt","r", encoding="utf-8")
data = f.read()
f.close()

# Entries are from 1 to 22491
data = data.strip().split("//")

def GetInfo(line):
    
    info = line.split()
    if len(info) < 2:
        return "Null"
    
    elif len(info) == 2:
        if info[1] == "-":
            return "Null"
        else: return info[1]
    
    elif len(info) > 2:
        
        return " ".join( info[1:len(info)] )
    

# Entry Format
    # 0: ID number
    # 2: Protein name
    # 3: Source
    # 4: Length
    # 5: MW
    # 6: PIR ID
    # 7: SwissProt ID
    # 8: E.C. Number
    # 9: PMD NO.
    # 10: Wild type PDB ID
    # 11: Mutant PDB ID
    # 12: Mutation
    # 13: Mutated Chain
    # 14: Number of Molecules
    # 18: Temperature
    # 19: pH
    # 20: Buffer name
    # 21: Buffer concentration
    # 24: Protein concentration 
    # 25: 1st measurement method
    # 26: 2nd measurement method
    
    # 28: dG_H20
    # 29: ddG_H20
    # 30: dG
    # 31: ddG
    # 32: Tm
    # 33: dTm
    # 34: dHvH
    # 35: dHcal
    # 36: m
    # 37: Cm
    # 38: dCp
    # 39: state
    # 40: Reversibility
    # 41: Activity
    # 42: Activity_Km
    # 43: Activity_Kcat
    # 44: Activity_Kd
    # 47: Reference
    # 48: Author
    # 50: Related entries

f = open("Protherm.csv","w")
f.write(
    """
    EntryID,Protein Name,Source,Length,Molecular Wt,PIR ID,SwissProtID,EC Number,PMD NO.,WT PDB,Mutant PDB,Mutation,Chain,dG_H2O,ddG_H2O,dG,ddG,T_m,dT_m
    """)

for i in range(1, 22492):

    entry = data[i].strip().split('\n')
    
    # Protein info
    entryid =       GetInfo(entry[0])
    protein_name =  GetInfo(entry[2])
    source =        GetInfo(entry[3])
    length =        GetInfo(entry[4])
    mw =            GetInfo(entry[5])
    pirid =         GetInfo(entry[6])
    swissprotid =   GetInfo(entry[7])
    ecnum =         GetInfo(entry[8])
    pmdnum =        GetInfo(entry[9])
    wtpdb =         GetInfo(entry[10])
    mutpdb =        GetInfo(entry[11])
    mutation =      GetInfo(entry[12])
    mutchain =      GetInfo(entry[13])
    
    # Energetics
    dgh2o =         GetInfo(entry[28])
    ddgh2o =        GetInfo(entry[29])
    dg =            GetInfo(entry[30])
    ddg =           GetInfo(entry[31])
    tm =            GetInfo(entry[32])
    dtm =           GetInfo(entry[33])
    ref =           GetInfo(entry[47])
    authors =       GetInfo(entry[48])
    related =       GetInfo(entry[50])
    
    newentry = (entryid+","+protein_name+","+source+","+length+","+mw+","+
                pirid+","+swissprotid+","+ecnum+","+pmdnum+","+wtpdb+","+
                mutpdb+","+mutation+","+mutchain+","+dgh2o+","+ddgh2o+","+
                dg+","+ddg+","+tm+","+dtm+"\n")
    
    f.write(newentry)
    
f.close()
    
    