import csv
import pandas as pd
import numpy as np
from collections import defaultdict
import seaborn as sns
import matplotlib.pyplot as plt

from sklearn.model_selection import train_test_split
from sklearn.naive_bayes import MultinomialNB
from sklearn import tree
from sklearn.tree import DecisionTreeClassifier

def prediction(list_to_predict, symptoms_list, clf_dt):
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
                
    pred = clf_dt.predict(new_df)
    return pred[0]

def pred(x):
    df_concat = pd.read_csv("final_data.csv")
    # One Hot Encoded Features
    cols = df_concat.columns
    cols = cols[1:]
    X = df_concat[cols]

    # Labels
    y = df_concat['disease']
    # Train Test Split
    X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=101)
    dt = DecisionTreeClassifier()
    clf_dt=dt.fit(X, y)
    symptoms_list = list(X_test.columns) 
    disease = prediction(x, symptoms_list, clf_dt)
    return disease