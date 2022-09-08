# Testing Hypotheses On Medical Insurance Costs

_**Tech used:** JupyterLab, Python, Pandas, Matplotlib, SciPy, NumPy_

**Note:** This is a summary of the project results. Click [here](https://github.com/NicolaBagala/portfolio/blob/master/insurance/insurance.ipynb) for the full project with code, or [here](https://github.com/NicolaBagala/portfolio/blob/master/insurance/codefree/insurance_codefree.ipynb) for a code-free version of the full project.<br><br>

<p align="justify">In this project, I tested a few different hypotheses on medical insurance costs, using a simulated dataset that should nonetheless reflect actual conditions in the USA. The hypotheses I wanted to test were:</p>

<ol>
  <li>Average medical expenses are the same for male and female patients.</li>
  <li>Average medical expenses are higher for people with higher <a href="https://en.wikipedia.org/wiki/Body_mass_index">BMI</a></li>
  <li>Smokers have higher average expenses than non-smokers.</li>
  <li>Medical expenses grow with age.</li>
</ol>

<p align="justify">
  <img src="codefree\figures\figure_1.png" align="right"  width="39%">
<strong>The first hypothesis was rejected with 95% confidence:</strong> the difference between male and female average expenses in the sample is indicative of a statistically significant difference at the population level. The best estimate for this difference is $1.387, meaning that, on average, male patients' expenditures are $1.387 higher than for female patients. The chance of observing this difference in a sample if there was no difference at the population level is less than 4%.</p>

<p align="justify">The two distributions, shown on the right, are very similar and with significant overlap, yet the small difference in their averages isn't statistically insignificant, although relatively small. Notice how the male distribution is slightly shorter around about $5.000, and higher around $40.000: a smaller fraction of men than women has moderate medical expenses, and a larger fraction of them has higher expenses.
</p>

<p align="justify" clear="right">As very few people in the dataset had a BMI that put them in the "underweight" category, I ignored these and focussed instead on the remaining three categories: normal weight, overweight, and obese. The chart below illustrates their medical expenditure distributions.
<br><br>
</p>

<p align="center">
  <img src="codefree\figures\figure_4.png">
<p>

<p align="justify">The normal-weight distribution (green) and the overweight one (yellow) are very similar and with significant overlap; their respective averages differ from each other only by $578, and the probability of observing this difference in the sample if there was no difference at the population level is as high as 37%. In contrast, the difference between the average expenditures of obese and normal-weight people is $5.143, and the probability of a observing a sample with such a difference if there was no difference in the population is essentially zero. The box plot on the right illustrates more clearly how the normal and overweight distributions are similar, whereas the distribution of expenditures of obese people is much more spread out with noticeably many more outliers. Ultimately, <strong>there is evidence to support the hypothesis that a higher BMI correlates with higher medical expenditures, but the difference is only significant for expenditures of obese people.</strong></p>

<p align="justify">The case of smokers was the most clear-cut of all: on average, their medical expenditures were over $23.000 higher than for non-smokers; at a 95% confidence level, the probability that this result was due to chance is negligible. The charts below illustrate the two distributions, which have very little overlap; notice how the box plot shows no outliers among smokers: their health expenditures are typically quite high, whereas very high medical expenditures among non-smokers are exceptional. <strong>The data is unequivocal that smokers have higher average expenditures than non-smokers.</strong><br><br></p>

<p align="center">
  <img src="codefree\figures\figure_7.png">
  <br><br>
</p>

<p align="justify">
  <img src="codefree\figures\figure_10.png" align="left"  width="39%">
Finally, when plotted against age, medical expenditures exhibit a linear growth that is, in a sense, "distributed" across three ranges of expenditures: low, medium, and high. The low range is represented by the data points below the red line; the medium range is between the red and the green line, while the high range is above the green line. (These lines are *not* the product of linear regression; they're just arbitrary dividers of the data.) The density of the data points decreases visibly with each range, suggesting that the medium and high range are outlier cases that are increasingly uncommon for any given age, while the low range represents typical medical expenditures for each age.<br><br>
</p>

<p align="justify">
All three ranges exhibit linear growth, suggesting a positive correlation between medical expenditures and age, although the strength of this correlation is weaker for the medium and high ranges. The chart below shows the results of linear regression and the residuals (the difference between the data and the linear model); we see a near perfect fit for the low range, a strong fit for the medium range, and a moderate fit for the high range. However, in all three cases, the probability that age and medical expenditures are uncorrelated in the population is essentially zero, as indicated by the p-value. Ultimately, <strong>the data strongly support the hypothesis that there is a positive correlation between medical expenditures and age.</strong><br><br></p>

<p align="center">
  <img src="codefree\figures\figure_11.png">
</p>

If you'd like to dig deeper into the details of the project, you'll find it in this repo, both with [code](https://github.com/NicolaBagala/portfolio/blob/master/insurance/insurance.ipynb) and [code-free](https://github.com/NicolaBagala/portfolio/blob/master/insurance/codefree/insurance_codefree.ipynb).
