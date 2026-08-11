#!/usr/bin/env python3
from pydriller import Repository
for c in Repository('../../').traverse_commits():
    print(c.hash[:8], c.msg.strip())
    break
