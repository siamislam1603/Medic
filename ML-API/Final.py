#!/usr/bin/env python
# coding: utf-8

# In[2]:


import joblib
import pickle
import csv
import pandas as pd
import numpy as np


# In[4]:
with open ('list_1.txt', 'rb') as fp:
    symptoms_list = pickle.load(fp)

def prediction(list_to_predict):
    loaded_model = joblib.load('finalized2_model.sav')
    # Column values
    val =[]
    for i in range(405):
        val.append(0)
    new_df = pd.DataFrame(val)
    new_df = new_df.transpose()
    new_df.columns = symptoms_list
                
    for x in list_to_predict:
        for i in symptoms_list:
            if (x==i):
                new_df[i]=1
                
    pred = loaded_model.predict(new_df)
    return pred[0]


# In[ ]:




