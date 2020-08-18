# -*- coding: utf-8 -*-
"""
Author:   Seth Thor
Created:  08/17/2020
Modified: 08/17/2020

EconSimProtoPy

Python prototype for EconSim agent-based simulation.
Simulate a basic economy based on the interactions between consumers
and producers bargaining over a product.

Once working here, code will be ported to C# code for integration
into web app.

"""

import numpy as np
import random as rnd
from scipy.stats import binom

class Agent:
    def __init__(integerID, money, type):
        self.ID = integerID
        self.wealth = money
        self.agenttype = type

    def getID(self):
        print(self.ID)

    def getwealth(self):
        print(self.wealth)

    def getagenttype(self):
        if self.agenttype == 0:
            print("Consumer")
        elif self.agenttype == 1:
            print("Producer")
            
def MakeInteractions(consumers, producers):
    
    # Generate random interactions between consumers and producers
    interactions = []
    consumers_copy = consumers
    producers_copy = producers
    while consumers_copy and producers_copy:
        c = rnd.choice(consumers)
        p = rnd.choice(producers)
        interactions.append((c, p))
        consumers_copy.remove(c)
        producers_copy.remove(p)
    
    return interactions

def bargain(offer_price, sell_price):
    
    # Consumer - increase offer_price incrementally until producer agrees
    # Producer: sell_price = desired_surplus + min_price
    # probability of acceptance, p = 1 - (offer_price / sell_price)
    # feed p into binomial distribution to determine if producer accepts
    
    p = 1 - (offer_price/sell_price)
    accept = binom.rvs(n=1, p=p)
    
    return accept
        

def simulation():

    # Num of iterations
    iter = 100

    # Initialize consumers/producers
    Nconsumers = 3
    Nproducers = 3
    consumers = [i for i in range(Nconsumers)]
    producers = [i for i in range(Nproducers)]

    # Distribute wealth among consumers and producers
    ## Consumers
    consumer_income = np.random.normal(20, 5, Nconsumers)
    consumer_wealth = np.random.normal(100, 100, Nconsumers)
    consumer_surplus = np.zeros(Nconsumers)
   
    
    ## Producers
    producer_wealth = np.random.normal(50, 10, Nproducers)
    producer_surplus = np.zeros(Nproducers)
    product_price = np.random.normal(20, 5, Nproducers)

    
    # Simulation loop
    for i in range(0,iter):
        interactions = MakeInteractions(consumers, producers)
        
        # Compute desired surpluses
        consumer_ds_percent = np.random.normal(0.05, 0.05, Nconsumers) # % increase in desired surplus
        consumer_surplus =  consumer_surplus*(1 + consumer_ds_percent)
        
        producer_ds_percent = np.random.normal(0.05, 0.05, Nproducers)
        producer_surplus = producer_surplus*(1 + producer_ds_percent)
        
        
        

    
    
    return

simulation()